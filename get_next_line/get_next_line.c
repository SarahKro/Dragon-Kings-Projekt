/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/01 19:54:44 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/19 20:16:10 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line.h"

// void	ft_bzero(void *s, size_t n)
// {
// 	unsigned char	*ptr;

// 	ptr = s;
// 	while (n > 0)
// 	{
// 		*ptr++ = '\0';
// 		n--;
// 	}
// }

// void	*ft_calloc(size_t nmemb, size_t size)
// {
// 	void	*m;
// 	size_t	product;

// 	if (nmemb != 0 && ((nmemb * size) / nmemb != size))
// 		return (NULL);
// 	product = nmemb * size;
// 	m = malloc(product);
// 	if (!m)
// 		return (NULL);
// 	ft_bzero(m, product);
// 	return (m);
// }

// size_t	ft_strlen(const char *s)
// {
// 	size_t	i;

// 	if(s == NULL)
// 		return(0);
// 	i = 0;
// 	while (s[i] != '\0')
// 	{
// 		i++;
// 	}
// 	return (i);
// }

char *fail_check(char *s1, char *s2, char *s3)
{
	if(!s1 && !s2)
	{
		// if(s3)
			free(s3);
		s3 = NULL;
		return(NULL);
	}
	else if(!s3)
	{
		if(s2)
			free(s2);
		if(s1)
			free(s1);
		// s3 = NULL;
		return(NULL);
	}
	return(NULL);
}
char	*ft_strjoin(char const *s1, char const *s2, int index, int size)
{
	int		i;
	char	*m;

	if (s1 == NULL && s2 == NULL)
		return (NULL);
	i = ft_strlen(s1);
	m = ft_calloc((i + size + 1), sizeof(char));
	if (!m)
		return (NULL);
	i = 0;
	while (s1 != NULL && s1[i] != '\0')
	{
		m[i] = s1[i];
		i++;
	}
	while (s2 != NULL && s2[index] != '\0' && index < size)
		m[i++] = s2[index++];
	m[i] = '\0';
	return (m);
}

int	new_line_check(char *small_buffer)
{
	int	i;

	i = 0;
	while (small_buffer && small_buffer[i] != '\0')
	{
		if (small_buffer[i] == '\n')
			return (i);
		i++;
	}
	return (-1);
}

char	*get_next_line(int fd)
{
	int			bytes_to_read;
	char		*small_buffer;
	char		*line;
	char		*temp;
	int			i;
	static char	*remain;

	line = NULL;
	temp = NULL;
	if (BUFFER_SIZE <= 0 || fd < 0)
		return (fail_check(temp, line, remain));
	if (remain)
	{
		i = new_line_check(remain);
		bytes_to_read = ft_strlen(remain);
		if (i > -1)
		{
			line = ft_strjoin(NULL, remain, 0, i + 1);
			if(!line && !temp)
			{
				// return (fail_check(temp, line, remain));
				free(remain);
				remain = NULL;
				return(NULL);
			}
			if (bytes_to_read > i + 1)
			{
				temp = remain;
				remain = ft_strjoin(NULL, remain, i + 1, bytes_to_read);
				free(temp);
				if(!remain)
				{
					free(line);
					// remain = NULL;
					return(NULL);
					// return (fail_check(temp, line, remain));
				}

			}
			else
			{
				free(remain);
				remain = NULL;
			}
			return(line);
		}
		else
		{
			line = ft_strjoin(line, remain, 0, bytes_to_read);
			if(!line)
			{
				free(remain);
				remain = NULL;
				// return (fail_check(temp, line, remain));
			}
		}
		free(remain);
		remain = NULL;
	}
	bytes_to_read = 1;
	while (bytes_to_read > 0)
	{
		small_buffer = ft_calloc(BUFFER_SIZE + 1, sizeof(char));
		if (!small_buffer)
		{
			if(line)
				free(line);
			return (NULL);
		}
		bytes_to_read = read(fd, small_buffer, BUFFER_SIZE);
		if (bytes_to_read < 0)
		{
			// free(small_buffer);
			// if(line)
			// 	free(line);		//	!!! THIS LINE WAS MISSING !!!
			// remain = NULL;
			return (fail_check(small_buffer, line, remain));
		}
		if ((bytes_to_read == 0) && line)
		{
			free(small_buffer);
			return(line);
		}
		i = new_line_check(small_buffer);
		if (i < 0)
		{
			temp = line;
			line = ft_strjoin(temp, small_buffer, 0, bytes_to_read);
			free(small_buffer);
			free(temp);
			if(!line)
				return(NULL);
		}
		else
		{
			temp = line;
			line = ft_strjoin(line, small_buffer, 0, (i + 1));
			if(!line)
			{
				// free(temp);
				// free(small_buffer);
				return(fail_check(temp, small_buffer, line));
			}
			free(temp);
			if (i + 1 < bytes_to_read)
			{
				remain = ft_strjoin(remain, small_buffer, i + 1, bytes_to_read);
				if(remain == NULL)
				{
					free(line);
					free(small_buffer);
					return(NULL);
				}
			}
			free(small_buffer);
			return (line);
		}
	}
	free(line);
	return (NULL);
}

// int	main(void)
// {
// 	int		fd;
// 	char	*text_line;
// 	int		count;

// 	count = 0;
// 	fd = open("7", O_RDONLY); // FILE options, open("path/to/file",
// 									// O_WRONLY | O_RONLY) flags can be combined
// 	//     O_RONLY, O_WONLY, O_RDWR MANDATORY FLAGS.
// 	if (fd == -1)
// 	{
// 		printf("no file");
// 		return (0);
// 	}
// 	while ((text_line = get_next_line(fd)) != NULL)
// 	{
// 		printf("Line %d: %s", ++count, text_line);
// 		free(text_line);
// 	}
// 	close(fd);
// 	return (0);
// }