/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.h                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: codespace <codespace@student.42.fr>        +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/09 16:47:54 by codespace         #+#    #+#             */
/*   Updated: 2024/10/09 16:47:56 by codespace        ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef LIBFTPRINTF_H
# define LIBFTPRINTF_H

# include <stdio.h>
# include <stdlib.h>
# include <unistd.h>

int	ft_putchar_fd(char c);
int	ft_putstr_fd(char *s);
int	ft_putnbr_fd(int n);
int	ft_printf(const char *format, ...);
int	ft_putnbr_hexa_lower(unsigned int n);
int	ft_putnbr_hexa_Upper(unsigned int n);
int	ft_putnbr_pointer_adress(size_t n);

#endif
