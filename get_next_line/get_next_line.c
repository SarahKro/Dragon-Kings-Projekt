/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/01 19:54:44 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/15 16:15:09 by codespace        ###   ########.fr       */
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
char	*ft_get_next_line(int fd)
{
	int bytes_to_read;
	char *small_buffer;
	char *line = NULL;
	char *temp;
    int i;
	int j;
    static char *remain;
	//static int r;

	if(BUFFER_SIZE <= 0 || fd < 0)
		return(NULL);
	if(remain && (i = new_line_check(remain) > -1))
	{
		i = new_line_check(remain);
		j = ft_strlen(remain);
		line = ft_strjoin(NULL, remain, 0, i + 1);
		if(j >= i + 1)
		{
			temp = remain;
			remain = ft_strjoin(NULL, remain, i+1, j);
			free(temp);
			return(line);
		}
		else
		{
			free(remain);
			remain = NULL;
		}
	}
	bytes_to_read = 1;
	while(bytes_to_read > 0)
	{
		if(remain)
		{
			i = ft_strlen(remain);
			if(i > 0)
				line = ft_strjoin(line, remain, 0, i);
			free(remain);
			remain = NULL;
		}
		small_buffer = ft_calloc (BUFFER_SIZE + 1, sizeof(char));
		if(!small_buffer)
			return(NULL);
		bytes_to_read = read(fd, small_buffer, BUFFER_SIZE);
		if (bytes_to_read <= 0)
        {
            free(small_buffer);
            return (NULL);
        }
        i = new_line_check(small_buffer);
    	if(i < 0)
		{
			temp = line;
			line = ft_strjoin(line, small_buffer, 0, bytes_to_read);
			if(temp)
				free(temp);
			free(small_buffer);
		}
		else
		{
			temp = line;
			line = ft_strjoin(line, small_buffer, 0, (i+1));
			free(temp);
			if(i+1 < bytes_to_read)
				remain = ft_strjoin(remain, small_buffer, i+1, bytes_to_read);
			free(small_buffer);
			return(line);
		}
	}
    return (NULL);
}
// int	main(void)
// {
// 	int fd;
// 	char *text_line;
// 	int count;

// 	count = 0;
// 	fd = open("7", O_RDONLY); // FILE options, open("path/to/file",
// 			// O_WRONLY | O_RONLY) flags can be combined
// 	//     O_RONLY, O_WONLY, O_RDWR MANDATORY FLAGS.
// 	if (fd == -1)
// 	{
// 		printf("no file");
// 		return (0);
// 	}
// 	while((text_line = ft_get_next_line(fd)) != NULL)
// 	{
// 		printf("Line %d: %s", ++count, text_line);
//         free(text_line);
// 	}
// 	close(fd);
// 	return (0);
// }
