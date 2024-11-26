#include "get_next_line.h"

static char	*remaining_check(char **remaining, char *line, int i)
{
	int		len;
	char	*temp;

	len = ft_strlen(*remaining);
	line = ft_strjoin(NULL, *remaining, 0, i + 1);
	if (!line)
		return (fail_check(NULL, remaining));
	if (len > i + 1)
	{
		temp = *remaining;
		*remaining = ft_strjoin(NULL, *remaining, i + 1, len);
		free(temp);
		if (!*remaining)
			return (fail_check(line, remaining));
	}
	else
	{
		if(remaining)
		{
			free(*remaining);
			*remaining = NULL;
		}
	}
	return (line);
}

static char	*remaining_writer(int bytes_to_read, char *line, char *small_buffer,
		char **remaining)
{
	int		index;
	char	*temp;

	index = new_line_check(small_buffer);
	temp = line;
	line = ft_strjoin(line, small_buffer, 0, (index + 1));
	free(temp);
	if (line == NULL)
		return (fail_check(small_buffer, remaining));
	if (index + 1 < bytes_to_read)
	{
		*remaining = ft_strjoin(NULL, small_buffer, index + 1, bytes_to_read);
		if (*remaining == NULL)
		{
			free(line);
			free(small_buffer);
			return (NULL);
		}
	}
	free(small_buffer);
	return (line);
}

static char	*ft_bytes_check(int bytes_to_read, char *line, char *small_buffer)
{
	if ((bytes_to_read == 0) && line)
	{
		free(small_buffer);
		return (line);
	}
	if (bytes_to_read <= 0)
	{
		free(small_buffer);
		if (line)
			free(line);
	}
	return (NULL);
}

static char	*line_reader(char *line, int bytes_to_read, int fd, char **remaining)
{
	char	*small_buffer;
	char	*temp;
	int		index;
	
	while (1)
	{
		small_buffer = ft_calloc(BUFFER_SIZE + 1, sizeof(char));//NULL;
		if (!small_buffer)
			return (fail_check(line, remaining));
		bytes_to_read = read(fd, small_buffer, BUFFER_SIZE);
		if (bytes_to_read <= 0 || (bytes_to_read == 0 && line))
			return (ft_bytes_check(bytes_to_read, line, small_buffer));
		index = new_line_check(small_buffer);
		if (index < 0)
		{
			temp = line;
			line = ft_strjoin(temp, small_buffer, 0, bytes_to_read);//NULL;
			free(small_buffer);
			free(temp);
			if (!line)
				return (NULL);
		}
		else
			return (remaining_writer(bytes_to_read, line, small_buffer, remaining));
	}
}

char	*get_next_line(int fd)
{
	int			bytes_to_read;
	char		*line;
	int			index;
	static char	*remaining[1045876];
	
	line = NULL;
	bytes_to_read = 0;
	if (BUFFER_SIZE <= 0 || fd < 0)
		return (NULL);
	index = new_line_check(remaining[fd]);
	if (remaining[fd] && index > -1)
		return (remaining_check(&remaining[fd], line, index));
	else if (remaining[fd])
	{
		bytes_to_read = ft_strlen(remaining[fd]);
		line = ft_strjoin(line, remaining[fd], 0, bytes_to_read);
		if (!line)
			return (fail_check(NULL, &remaining[fd]));
		free(remaining[fd]);
		remaining[fd] = NULL;
	}
	return (line_reader(line, bytes_to_read, fd, &remaining[fd]));
}
