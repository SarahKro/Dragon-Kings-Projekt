/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: krh <krh@student.42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/01 19:54:44 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/23 21:13:19 by krh              ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line.h"

char	*ft_first_if(char **remain, char *line, int i)
{
	int		size;
	char	*temp;

	size = ft_strlen(*remain);
	line = ft_strjoin(NULL, *remain, 0, i + 1);
	if (!line)
		return (fail_check(NULL, *remain));
	if (size > i + 1)
	{
		temp = *remain;
		*remain = ft_strjoin(NULL, *remain, i + 1, size);
		free(temp);
		if (!*remain)
			return (fail_check(line, *remain));
	}
	free(*remain);
	*remain = NULL;
	return (line);
}

char	*ft_else(int bytes_to_read, char *line, char *small_buffer,
		char **remain)
{
	int		i;
	char	*temp;

	i = new_line_check(small_buffer);
	temp = line;
	line = ft_strjoin(line, small_buffer, 0, (i + 1));
	free(temp);
	if (line == NULL)
		return (fail_check(small_buffer, *remain));
	if (i + 1 < bytes_to_read)
	{
		*remain = ft_strjoin(NULL, small_buffer, i + 1, bytes_to_read);
		if (*remain == NULL)
		{
			free(line);
			free(small_buffer);
			return (NULL);
		}
	}
	free(small_buffer);
	return (line);
}

char	*ft_bytes_check(int bytes_to_read, char *line, char *small_buffer, char *remain)
{
	if(remain)
	{
		free(remain);
		remain = NULL;
	}
	if ((bytes_to_read == 0) && line)
	{
		free(small_buffer);
		return (line);
	}
	if (bytes_to_read <= 0)
	{
		free(small_buffer);
		if (line)
			free(line);
	}
	return (NULL);
}

char	*ft_loop(char *line, int bytes_to_read, int fd, char **remain)
{
	char	*small_buffer;
	char	*temp;
	int		i;

	while (1)
	{
		small_buffer = ft_calloc(BUFFER_SIZE + 1, sizeof(char));
		if (!small_buffer)
			return (fail_check(line, *remain));
		bytes_to_read = read(fd, small_buffer, BUFFER_SIZE);
		if (bytes_to_read <= 0 || (bytes_to_read == 0 && line))
			return (ft_bytes_check(bytes_to_read, line, small_buffer, *remain));
		i = new_line_check(small_buffer);
		if (i < 0)
		{
			temp = line;
			line = ft_strjoin(temp, small_buffer, 0, bytes_to_read);
			free(small_buffer);
			free(temp);
			if (!line)
				return (NULL);
		}
		else
			return (ft_else(bytes_to_read, line, small_buffer, remain));
	}
}

char	*get_next_line(int fd)
{
	int			bytes_to_read;
	char		*line;
	int			i;
	static char	*remain;

	line = NULL;
	bytes_to_read = 0;
	if (BUFFER_SIZE <= 0 || fd < 0)
		return (fail_check(NULL, remain));
	i = new_line_check(remain);
	if (remain && i > -1)
		return (ft_first_if(&remain, line, i));
	else if (remain)
	{
		bytes_to_read = ft_strlen(remain);
		line = ft_strjoin(line, remain, 0, bytes_to_read);
		if (!line)
			return (fail_check(NULL, remain));
		free(remain);
		remain = NULL;
	}
	return (ft_loop(line, bytes_to_read, fd, &remain));
}

int	main(void)
{
	int		fd;
	char	*text_line;
	int		count;

	count = 0;
	// text_line = get_next_line(0);
	// printf("%s", text_line);
	fd = open("3.txt", O_RDONLY);
	if (fd == -1)
	{
		printf("no file");
		return (0);
	}
	while ((text_line = get_next_line(fd)) != NULL)
	{
		printf("Line %d: %s", ++count, text_line);
		free(text_line);
	}
	close(fd);
	return (0);
}
