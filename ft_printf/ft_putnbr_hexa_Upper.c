/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_hexa_Upper.c                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/07 18:08:16 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/10 10:59:45 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

int	ft_putnbr_hexa_Upper(unsigned int n)
{
	char	str[32];
	char *base = "0123456789ABCDEF";
	int	i;
	int	save;
    unsigned long nbr;
	
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
	i-=1;
	while (i >= 0)
	{
		write(1, &str[i], 1);
		i--;
	}
	return (save);
}

