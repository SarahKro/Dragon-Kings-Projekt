/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.h                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: krh <krh@student.42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/04 12:24:30 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/23 21:08:40 by krh              ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef Get_next_line_H
# define Get_next_line_H

# ifndef BUFFER_SIZE
#  define BUFFER_SIZE 3
# endif

# include <fcntl.h>
# include <stdio.h>
# include <stdlib.h>
# include <unistd.h>

char	*ft_strjoin(char const *s1, char const *s2, int size, int index);
char	*get_next_line(int fd);
void	*ft_calloc(size_t nmemb, size_t size);
void	ft_bzero(void *s, size_t n);
char	*ft_strncpy(char *dest, char *src, unsigned int n);
char	*ft_strchr(const char *s, int c);
char	*ft_strcpy(char *dest, char *src);
size_t	ft_strlen(const char *s);
int		new_line_check(char *small_buffer);
char	*ft_loop(char *line, int bytes_to_read, int fd, char **remain);
char	*ft_first_if(char **remain, char *line, int i);
char	*ft_else(int bytes_to_read, char *line, char *small_buffer,
			char **remain);
char	*fail_check(char *s1, char *s2);
char	*ft_bytes_check(int bytes_to_read, char *line, char *small_buffer,
			char *remain);

#endif
