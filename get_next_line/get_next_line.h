/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.h                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/04 12:24:30 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/15 19:38:21 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef Get_next_line_H
# define Get_next_line_H

#ifndef BUFFER_SIZE
# define BUFFER_SIZE 3
#endif

#include <stdlib.h>
#include <unistd.h>
#include <fcntl.h>
#include <stdio.h>

char	*ft_strjoin(char const *s1, char const *s2, int size, int index);
char	*get_next_line(int fd);
void	*ft_calloc(size_t nmemb, size_t size);
void	ft_bzero(void *s, size_t n);
char	*ft_strncpy(char *dest, char *src, unsigned int n);
char	*ft_strchr(const char *s, int c);
char	*ft_strcpy(char *dest, char *src);
size_t	ft_strlen(const char *s);
int     new_line_check(char *small_buffer);


#endif
