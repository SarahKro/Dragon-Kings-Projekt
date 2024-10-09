/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putnbr_hexa_lower.c                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/09/19 18:47:11 by sizgi             #+#    #+#             */
/*   Updated: 2024/10/09 16:46:23 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

// int	ft_putnbr_hexa_lower(unsigned long n)
// {
// 	char	str[32];
// 	char *base = "0123456789abcdef";
// 	int	i;
// 	int	save;

// 	i = 0;
// 	while (n > 0)
// 	{
// 		str[i++] = base[(n % 16)];
// 		n = n / 16;
// 	}
// 	save = i;
// 	i-=1;
// 	while (i >= 0)
// 	{
// 		write(1, &str[i], 1);
// 		i--;
// 	}
// 	return (save);
// }
int	ft_putnbr_hexa_lower(unsigned int n)
{
    char	str[32];
    char	*base = "0123456789abcdef";
    int		i;
    int		save;
    unsigned long num;

    if (n == 0)
    {
        write(1, "0", 1);
        return (1);
    }

    num = (unsigned long)n; // Handle negative numbers by converting to unsigned

    i = 0;
    while (num > 0)
    {
        str[i++] = base[(num % 16)];
        num = num / 16;
    }
    save = i;
    i -= 1;
    while (i >= 0)
    {
        write(1, &str[i], 1);
        i--;
    }
    return (save);
}
