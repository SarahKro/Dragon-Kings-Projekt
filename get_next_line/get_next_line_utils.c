/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line_utils.c                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/11 15:06:07 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/15 19:45:51 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line.h"

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
	size_t	product;

	if (nmemb != 0 && ((nmemb * size) / nmemb != size))
		return (NULL);
	product = nmemb * size;
	m = malloc(product);
	if (!m)
		return (NULL);
	ft_bzero(m, product);
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
char	*ft_strdup(const char *s)
{
	int		i;
	int		j;
	char	*m;

	j = 0;
	i = 0;
	while (s[i] != '\0')
		i++;
	m = malloc((i + 1) * sizeof(char));
	if (!m)
		return (0);
	while (s[j] != '\0')
	{
		m[j] = s[j];
		j++;
	}
	m[j] = '\0';
	return (m);
}
