/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line_utils.c                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/11 15:06:07 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/03 17:02:27 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "Get_next_line.h"

void	ft_bzero(void *s, size_t n)
{
	unsigned char	*ptr;

	ptr = s;
	while (n > 0)
	{
		*ptr++ = '\0';
		n--;
	}
}

void	*ft_calloc(size_t nmemb, size_t size)
{
	void	*m;
	size_t	sum;

	if (nmemb != 0 && ((nmemb * size) / nmemb != size))
		return (NULL);
	sum = nmemb * size;
	m = malloc(sum);
	if (!m)
		return (NULL);
	ft_bzero(m, sum);
	return (m);
}

size_t	ft_strlen(const char *s)
{
	size_t	i;

	if(s == NULL)
		return(0);
	i = 0;
	while (s[i] != '\0')
	{
		i++;
	}
	return (i);
}

// char	*ft_strjoin(char const *s1, char const *s2, int size, int index)
// {
// 	int		i;
// 	char	*m;

// 	if (s1 == NULL && s2 == NULL)
// 		return (NULL);
// 	i = ft_strlen(s1);
// 	m = ft_calloc((i + size + 1), sizeof(char));
// 	if (!m)
// 		return (NULL);
// 	i = 0;
// 	while (s1 != NULL && s1[i] != '\0')
// 	{
// 		m[i] = s1[i];
// 		i++;
// 	}
// 	while (s2 != NULL && s2[index] != '\0' && index < size)
// 		m[i++] = s2[index++];
// 	m[i] = '\0';
// 	return (m);
// }

char	*ft_strchr(const char *s, int c)
{
	char	*ptr;
	int		i;

	ptr = (char *)s;
	i = 0;
	while (ptr[i] != '\0')
	{
		if (ptr[i] == (unsigned char)c)
			return (&ptr[i]);
		i++;
	}
	if ((unsigned char)c == '\0')
		return (&ptr[i]);
	return (NULL);
}
char	*ft_strcpy(char *dest, char *src)
{
	int	i;

	i = 0;
	while (src[i] != '\0')
	{
		dest[i] = src[i];
		i++;
	}
	dest[i] = src[i];
	return (dest);
}
char	*ft_strncpy(char *dest, char *src, unsigned int n)
{
	unsigned int	i;

	i = 0;
	while (i < n && src[i] != '\0')
	{
		dest[i] = src[i];
		i++;
	}
	while (i < n)
	{
		dest[i] = '\0';
		i++;
	}
	return (dest);
}
