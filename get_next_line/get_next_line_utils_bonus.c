
#include "get_next_line.h"


int	new_line_check(char *small_buffer)
{
	int	i;

	i = 0;
	while (small_buffer && small_buffer[i] != '\0')
	{
		if (small_buffer[i] == '\n')
			return (i);
		i++;
	}
	return (-1);
}

void	*ft_calloc(size_t nmemb, size_t size)
{
	size_t			sum;
	void			*m;
	unsigned char	*ptr;

	if (nmemb != 0 && ((nmemb * size) / nmemb != size))
		return (NULL);
	sum = nmemb * size;
	m = malloc(sum);
	if (!m)
		return (NULL);
	ptr = m;
	while (sum > 0)
	{
		*ptr++ = '\0';
		sum--;
	}
	return (m);
}

size_t	ft_strlen(const char *s)
{
	size_t	i;

	if (s == NULL)
		return (0);
	i = 0;
	while (s[i] != '\0')
	{
		i++;
	}
	return (i);
}

char	*ft_strjoin(char const *s1, char const *s2, int index, int size)
{
	int		i;
	char	*m;

	if (s1 == NULL && s2 == NULL)
		return (NULL);
	i = ft_strlen(s1);
	m = ft_calloc((i + size + 1), sizeof(char));
	if (!m)
		return (NULL);
	i = 0;
	while (s1 != NULL && s1[i] != '\0')
	{
		m[i] = s1[i];
		i++;
	}
	while (s2 != NULL && s2[index] != '\0' && index < size)
		m[i++] = s2[index++];
	m[i] = '\0';
	return (m);
}

char	*fail_check(char *s1, char **s2)
{
	if (s1)
		free(s1);
	if (*s2)
		free(*s2);
	*s2 = NULL;
	return (NULL);
}
