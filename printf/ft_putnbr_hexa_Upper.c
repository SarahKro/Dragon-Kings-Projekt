/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_hexa_Upper.c                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/07 18:08:16 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/09 13:30:22 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libftprintf.h"

int	ft_putnbr_hexa_Upper(unsigned int n)
{
	char	str[32];
	char *base = "0123456789ABCDEF";
	int	i;
	int	save;

	i = 0;
	while (n > 0)
	{
		str[i++] = base[(n % 16)];
		n = n / 16;
	}
	save = i;
	i-=1;
	while (i >= 0)
	{
		write(1, &str[i], 1);
		i--;
	}
	return (save);
}

