/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.h                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/11/20 15:32:11 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/20 16:20:01 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef FT_PRINTF_H
# define FT_PRINTF_H

# include <stdarg.h>
# include <unistd.h>

int	ft_putchar_fd(char c);
int	ft_putstr_fd(char *s);
int	ft_putnbr_fd(int n);
int	ft_printf(const char *format, ...);
int	ft_putnbr_hexa_lower(unsigned int n);
int	ft_putnbr_hexa_upper(unsigned int n);
int	ft_putnbr_pointer_adress(size_t n);
int	ft_unsigned_int(unsigned int n);

#endif
