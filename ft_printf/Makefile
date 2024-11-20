# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2024/11/20 14:12:29 by sizgi             #+#    #+#              #
#    Updated: 2024/11/20 14:47:08 by sizgi            ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

SRC = ft_printf.c ft_putchar_fd.c ft_putnbr_fd.c ft_putnbr_hexa_lower.c \
ft_putnbr_hexa_upper.c ft_putnbr_pointer_adress.c \
ft_putstr_fd.c ft_unsigned_int.c

OBJ = $(SRC:.c=.o)

NAME = libftprintf.a

CFLAGS = -Wall -Werror -Wextra

RM = rm -f

all: $(NAME)

$(NAME): $(OBJ)
	ar rcs $(NAME) $(OBJ)

clean:
	$(RM) $(OBJ)

fclean: clean
	$(RM) $(NAME)

re: fclean all

.PHONY: all clean fclean re
