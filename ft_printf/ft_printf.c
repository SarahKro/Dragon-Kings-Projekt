/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2024/10/08 14:20:39 by sizgi             #+#    #+#             */
/*   Updated: 2024/11/20 15:37:23 by sizgi            ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"

static int	ft_the_decision(va_list ap, char c)
{
	int	i;

	i = 0;
	if (c == 'c')
		i = ft_putchar_fd(va_arg(ap, int));
	else if (c == 's')
		i = ft_putstr_fd(va_arg(ap, char *));
	else if (c == 'p')
		i = ft_putnbr_pointer_adress(va_arg(ap, size_t));
	else if (c == 'i' || c == 'd')
		i = ft_putnbr_fd(va_arg(ap, int));
	else if (c == 'u')
		i = ft_unsigned_int(va_arg(ap, unsigned int));
	else if (c == 'x')
		i = ft_putnbr_hexa_lower(va_arg(ap, unsigned int));
	else if (c == 'X')
		i = ft_putnbr_hexa_upper(va_arg(ap, unsigned int));
	else if (c == '%')
		i = ft_putchar_fd('%');
	return (i);
}

int	ft_printf(const char *format, ...)
{
	int		i;
	va_list	ap;
	int		save;

	i = 0;
	save = 0;
	if (format == NULL)
		return (0);
	va_start(ap, format);
	while (format[i] != '\0')
	{
		if (format[i] == '%')
		{
			i++;
			save = save + ft_the_decision(ap, format[i]);
		}
		else
		{
			ft_putchar_fd(format[i]);
			save++;
		}
		i++;
	}
	va_end(ap);
	return (save);
}
// #include <limits.h>

// int	main(void)
// {
// 	char	*s;

// 	s = NULL;
// 	printf("\n%p  ", "");
// 	printf("%p  ", NULL);
// 	printf("%p  ", (void *)-14523);
// 	printf("0x%p-  ", (void *)ULONG_MAX);
// 	printf("%pp%p%p  ", (void *)LONG_MAX + 423856, (void *)0, (void *)INT_MAX);
// 	printf(" NULL %s NULL ", s);
// 	printf(" %p %p \n", (void *)0, (void *)0);
// 	ft_printf("%p  ", "");
// 	ft_printf("%p  ", NULL);
// 	ft_printf("%p  ", (void *)-14523);
// 	ft_printf("0x%p-  ", (void *)ULONG_MAX);
// 	ft_printf("%pp%p%p  ", (void *)LONG_MAX + 423856, (void *)0,
// 		(void *)INT_MAX);
// 	ft_printf(" NULL %s NULL ", s);
// 	ft_printf(" %p %p \n", (void *)0, (void *)0);
// }
// 	ft_printf("%p", NULL);
// 	printf("%p", NULL);
// }
// {
// 	int  a = 0;
// 	int b = 0;
// 	// char c = 'a';
// 	char *s = "hi there";
// 	//int i = 0;
// 	//int d = 100;
// 	//int j = 2147483647;
// 	//int k = 214748367;
// 	printf("start Check\n");
// 	printf("---------FT---------\n");
// 	// printf("NULL %p\n", NULL);
// 	// ft_printf("NULL %p\n", NULL);
// 	//printf("%p %p\n", 0, 0);
// 	// printf("%p %p\n", 0, 0);
// 	// b +=printf("%s", NULL);
// 	// ft_printf(" NULL %s NULL ", NULL);
// 	//a += ft_printf("%d %i %s", 5,INT_MIN,"hello world");
// 	//a += ft_printf("%X%X%d%i%x\n",0,INT_MIN,2,3,INT_MAX);
// 	a += ft_printf("%d %d %d %p %d %d %i %i %X %d %x \n", 76217847, 1254,
// 			1234568, &s, 1235468, 24568, 100000, 4358725, 100000, 100000,
// 			100000);
// 	b += printf("%d %d %d %p %d %d %i %i %X %d %x \n", 76217847, 1254,
// 			1234568, &s, 1235468, 24568, 100000, 4358725, 100000, 100000,
// 			100000);
// 	printf("\n---------STD---------\n");
// 	// b += printf("%d %i %s", 5,INT_MIN,"hello world");
// 	// b += printf("%X%X%d%i%x\n",0,INT_MIN,2,3,INT_MAX);
// 	printf("\nEnd\n");
// 	printf("Result : ft: %d / std: %d\n",a,b);
// }
/* int	main(void)
{
   int		j;
   int		k;
   int		d;
   int		i;
   char	c;
   char	*s;
	int	a;
	int	b;

	a = 0;
	b = 0;
//    a += ft_printf("%d %d %d %p %d %d %i %i %X %d %x \n", 76217847, 1254,
// 		1234568, &s, 1235468, 24568, 100000, 4358725, 100000, 100000, 100000);
//    b += printf("%d %d %d %p %d %d %i %i %X %d %x \n", 76217847, 1254,
		1234568,
// 		&s, 1235468, 24568, 100000, 4358725, 100000, 100000, 100000);
//    a += ft_printf("%c %s %p %d %i %d %X %u %x %%%% \n", c, s, &s, d, i, j, k,
		j,
// 		k);
   // int a_age = 0;
   // 5 is the nustrber of nustrbers
   // a_age = average(5,            10, 15, 10, 15, 5);
   // printf("The average age of those 5 is : %d\n", a_age);
   // return(0);
   // char c = 'S';
   // long i;
   j = 2147483647;
   k = 214748367;
   // int u = 999;
   d = 998;
   i = 997;
   c = 'Z';
   s = "abcdef";
   // long i = 536;
   a += ft_printf("%c %s %p %d %i %d %X %u %x %%%% \n", c, s, &s, d, i, j, k, j,
		k);
   b += printf("%c %s %p %d %i %d %X %u %x %%%% \n", c, s, &s, d, i, j, k, j,
		k);
//    ft_printf("%u\n", j);
//    printf("%u\n", j);
	ft_printf("ft: %d\nprint: %d", a, b);
   // printf ("Decistrals: % %ld\n", 1977, 650000L);
//    printf("Preceding with blanks: %10d \n", 1977);
//    printf("Preceding with zeros: %010d \n", 1977);
   // printf ("floats: %4.2f %+.0e %E \n", 3.1416, 3.1416, 3.1416);
   // printf ("Width trick: %*d \n", 5, 10);
   // printf ("%s \n", "A string");
   // //printf ("%ld", i);
   return (0);
}
 */