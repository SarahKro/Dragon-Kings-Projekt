/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_hexa_lower.c                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/19 18:47:11 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/20 14:40:42 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

int	ft_putnbr_hexa_lower(unsigned int n)
{
	char			str[32];
	char			*base;
	int				i;
	int				save;
	unsigned long	nbr;

	base = "0123456789abcdef";
	if (n == 0)
	{
		write(1, "0", 1);
		return (1);
	}
	nbr = (unsigned long)n;
	i = 0;
	while (nbr > 0)
	{
		str[i++] = base[(nbr % 16)];
		nbr = nbr / 16;
	}
	save = i;
	i -= 1;
	while (i >= 0)
		write(1, &str[i--], 1);
	return (save);
}
