/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line_utils.c                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/11 15:06:07 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/12 15:56:22 by codespace        ###   ########.fr       */
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

