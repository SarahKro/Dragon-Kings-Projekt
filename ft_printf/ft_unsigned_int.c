/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_unsigned_int.c                                  :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/20 15:32:38 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/20 15:57:49 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

int	ft_unsigned_int(unsigned int n)
{
	int	nbr;
	int	i;

	i = 0;
	if (n >= 10)
	{
		i += ft_unsigned_int((n / 10));
	}
	nbr = n % 10 + '0';
	write(1, &nbr, 1);
	i++;
	return (i);
}

/* #include <stdio.h>

int	main(void)
{
	ft_unsigned_int(2147483648);
	printf("\n%u \n", 2147483647);
	return (0);
} */