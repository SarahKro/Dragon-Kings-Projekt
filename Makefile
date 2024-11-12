# **************************************************************************** #
#                                                                              #
#                                                         :::      ::::::::    #
#    Makefile                                           :+:      :+:    :+:    #
#                                                     +:+ +:+         +:+      #
#    By: sizgi <sizgi@student.42.fr>                +#+  +:+       +#+         #
#                                                 +#+#+#+#+#+   +#+            #
#    Created: 2024/10/18 14:12:57 by sizgi             #+#    #+#              #
#    Updated: 2024/11/03 16:15:29 by sizgi            ###   ########.fr        #
#                                                                              #
# **************************************************************************** #

SRC = 6_get_next_line.c get_next_line_utils.c

OBJ = $(SRC:.c=.o)

NAME = get_next_line.a

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
