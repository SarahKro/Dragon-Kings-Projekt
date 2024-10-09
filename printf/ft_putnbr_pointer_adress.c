/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_pointer_adress.c                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/07 18:11:20 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/09 15:47:24 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libftprintf.h"

int	ft_putnbr_pointer_adress(size_t n)
{
	char	str[32];
	char *base = "0123456789abcdef";
	int	i;
	int	save;

	i = 0;
	while (n > 0)
	{
		str[i++] = base[(n % 16)];
		n = n / 16;
	}
	save = i + 2;
	write(1, "0x", 2);
	i -= 1;
	while (i >= 0)
	{
		write(1, &str[i], 1);
		i--;
	}
	return (save);
}
