# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2024/10/08 14:26:01 by sizgi             #+#    #+#              #
#    Updated: 2024/10/08 17:46:26 by sizgi            ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

SRC = ft_printf.c ft_putchar_fd.c ft_putnbr_fd.c ft_putnbr_hexa_lower.c \
ft_putnbr_hexa_Upper.c ft_putnbr_pointer_adress.c ft_putstr_fd.c

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
