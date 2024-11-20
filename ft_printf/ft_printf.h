/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.h                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/20 15:32:11 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/20 15:06:48 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef FT_PRINTF_H
# define FT_PRINTF_H

// # include <stdio.h>
# include <stdlib.h>
# include <unistd.h>
# include <stdarg.h>

int	ft_putchar_fd(char c);
int	ft_putstr_fd(char *s);
int	ft_putnbr_fd(int n);
int	ft_printf(const char *format, ...);
int	ft_putnbr_hexa_lower(unsigned int n);
int	ft_putnbr_hexa_upper(unsigned int n);
int	ft_putnbr_pointer_adress(size_t n);
int	ft_unsigned_int(unsigned int n);

#endif
