/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_hexa_Upper.c                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/07 18:08:16 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/09 16:46:30 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

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

