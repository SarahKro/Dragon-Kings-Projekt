#ifndef Get_next_line_H
# define Get_next_line_H

# ifndef BUFFER_SIZE
#  define BUFFER_SIZE 10
# endif

# include <fcntl.h>
# include <stdio.h>
# include <stdlib.h>
# include <unistd.h>

char	*ft_strjoin(char const *s1, char const *s2, int size, int index);
char	*get_next_line(int fd);
void	*ft_calloc(size_t nmemb, size_t size);
size_t	ft_strlen(const char *s);
int		new_line_check(char *small_buffer);
char	*fail_check(char *s1, char **s2);

#endif
