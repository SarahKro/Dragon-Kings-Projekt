/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/01 19:54:44 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/16 18:13:26 by codespace        ###   ########.fr       */
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
	int			j;
	static char	*remain;

	line = NULL;
	if (BUFFER_SIZE <= 0 || fd < 0)
	{
		if(remain)
			free(remain);
		remain = NULL;
		return(NULL);
	}
	i = new_line_check(remain);
	if (remain && i > -1)
	{
		j = ft_strlen(remain);
		line = ft_strjoin(NULL, remain, 0, i + 1);
		if(line == NULL)
		{
			free(line);
			free(remain);
			remain = NULL;
			return(NULL);
		}
		if (j > i + 1)
		{
			temp = remain;
			remain = ft_strjoin(NULL, remain, i + 1, j);
			free(temp);
			if(remain == NULL)
			{
				free(line);
				return(NULL);
			}
			return (line);
		}
		else
		{
			free(remain);
			remain = NULL;
		}
	}
	bytes_to_read = 1;
	while (bytes_to_read > 0)
	{
		if (remain)
		{
			i = ft_strlen(remain);
			if (i > 0)
			{
				line = ft_strjoin(line, remain, 0, i);
				if(line == NULL)
				{
					free(small_buffer);
					if(remain)
					{
						free(remain);
						remain = NULL;
					}
					return(NULL);
				}
			}
			free(remain);
			remain = NULL;
		}
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
			free(small_buffer);
			free(line);		//	!!! THIS LINE WAS MISSING !!!
			if(remain)
			{
				free(remain);
				remain = NULL;
			}
			return (NULL);
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
			line = ft_strjoin(line, small_buffer, 0, bytes_to_read);
			if (temp)
				free(temp);
			free(small_buffer);
			if(line == NULL)
				return(NULL);
		}
		else
		{
			temp = line;
			line = ft_strjoin(line, small_buffer, 0, (i + 1));
			if(line == NULL)
			{
				free(temp);
				free(small_buffer);
				// if(remain)
				// {
				// 	free(remain);
				// 	remain = NULL;
				// }
				return(NULL);
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
// 	fd = open("read_error.txt", O_RDONLY); // FILE options, open("path/to/file",
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
