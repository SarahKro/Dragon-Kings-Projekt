/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/01 19:54:44 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/13 16:17:40 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line.h"

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
int new_line_check(char *small_buffer)
{
    int i;
    
    i = 0;
    while (small_buffer && small_buffer[i] != '\0')
    {
        if (small_buffer[i] == '\n')
            return(i);
        i++;
    }
    return(-1);
}
char	*get_next_line(int fd)
{
	int bytes_to_read;
	char *small_buffer;
	char *line;
	char *temp;
    int i;
	int j;
    static char *remain;

	if(BUFFER_SIZE <= 0 || fd < 0)
		return(NULL);
	small_buffer = ft_calloc (BUFFER_SIZE + 1, sizeof(char));
	if(!small_buffer)
		return(NULL);
	if(remain)
	{
		i = new_line_check(remain);
		j = ft_strlen(remain);
		if(i >= 0)
		{
			temp = remain;
			line = ft_strjoin(line, remain, 0, i+1);
			free(temp);
			remain = ft_strjoin(NULL,remain, i+1, j);
			return(line);
		}
	}
	bytes_to_read = 1;
	while(bytes_to_read > 0)
	{
		bytes_to_read = read(fd, small_buffer, BUFFER_SIZE);
		if (bytes_to_read <= 0)
        {
            free(small_buffer);
            return (NULL);
        }
		small_buffer[bytes_to_read] = '\0';
        i = new_line_check(small_buffer);
    	if(i < 0)
		{
			temp = remain;
			remain = ft_strjoin(remain, small_buffer, 0, bytes_to_read);
			free(temp);
		}
		else
		{
			line = ft_strjoin(remain, small_buffer, 0, (i+1));
			free(remain);
			remain = NULL;
			if(i+1 < bytes_to_read)
				remain = ft_strjoin(remain,small_buffer, i+1, bytes_to_read);
			free(small_buffer);
			return(line);
		}
	}
		free(small_buffer);
    	if (remain && *remain)
    	{
			line = remain;
			remain = NULL;
			return (line);
    	}
    return (NULL);	//size_t read(int fildes, void *buf, size_t nbyte);
}
int	main(void)
{
	int fd;
	char *text_line;
	int count;

	count = 0;
	fd = open("exampuru.txt", O_RDONLY); // FILE options, open("path/to/file",
			// O_WRONLY | O_RONLY) flags can be combined
	//     O_RONLY, O_WONLY, O_RDWR MANDATORY FLAGS.
	if (fd == -1)
	{
		printf("no file");
		return (0);
	}
	// while (1)
	// {
	// 	text_line = get_next_line(fd);
	// 	// printf("%s", text_line);
	// 	if (text_line == NULL)
	// 		return (0);
	// 	count++;
	// 	printf("%s", text_line);
	// 	free(text_line);
	// 	text_line = NULL;
	// }
	while((text_line = get_next_line(fd)) != NULL)
	{
		printf("Line %d: %s", ++count, text_line);
        free(text_line);
	}
	close(fd);
	return (0);
}
