/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_fd.c                                     :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/19 18:47:11 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/10 10:24:38 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

int	ft_putnbr_fd(int n)
{
	int	nbr;
	int i;

	i = 0;
	if (n == -2147483648)
	{
		write(1, "-2147483648", 11);
		return(11) ;
	}
	if (n < 0)
	{
		write(1, "-", 1);
		n = n * (-1);
		i++;
	}
	if (n >= 10)
	{
		i += ft_putnbr_fd((n / 10));
	}
	nbr = n % 10 + '0';
	write(1, &nbr, 1);
	i++;
	return (i);
}