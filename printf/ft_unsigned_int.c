/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_unsigned_int.c                                  :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/10 10:15:41 by codespace         #+#    #+#             */
/*   Updated: 2024/10/10 10:15:43 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

int	ft_unsigned_int(unsigned int n)
{
	int	nbr;
	int i;

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

int main()
{
    ft_unsigned_int(2147483648);
    printf("\n%u \n", 2147483647);
    return 0;
} */