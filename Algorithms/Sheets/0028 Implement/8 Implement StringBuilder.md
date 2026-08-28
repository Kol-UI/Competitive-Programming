Implement StringBuilder

```cs
// Implement your own version of StringBuilder
// Approach 1: single resizable char array (like a List<char>), doubles capacity when full
// Approach 2: chunked storage, a list of string pieces joined only when ToString is called

public class ArrayStringBuilder
{
    private char[] _buffer;
    private int _length;

    public ArrayStringBuilder(int initialCapacity = 16)
    {
        if (initialCapacity <= 0)
            throw new ArgumentException("Capacity must be positive");
        _buffer = new char[initialCapacity];
        _length = 0;
    }

    public int Length => _length;

    // Grow the buffer when it runs out of space
    private void EnsureCapacity(int extra)
    {
        if (_length + extra <= _buffer.Length)
            return;

        var newCapacity = Math.Max(_buffer.Length * 2, _length + extra);
        var newBuffer = new char[newCapacity];
        Array.Copy(_buffer, newBuffer, _length);
        _buffer = newBuffer;
    }

    public ArrayStringBuilder Append(string value)
    {
        EnsureCapacity(value.Length);
        value.CopyTo(0, _buffer, _length, value.Length);
        _length += value.Length;
        return this;
    }

    public ArrayStringBuilder Append(char value)
    {
        EnsureCapacity(1);
        _buffer[_length] = value;
        _length++;
        return this;
    }

    public ArrayStringBuilder Insert(int index, string value)
    {
        if (index < 0 || index > _length)
            throw new ArgumentOutOfRangeException(nameof(index));

        EnsureCapacity(value.Length);
        // shift existing tail to the right
        Array.Copy(_buffer, index, _buffer, index + value.Length, _length - index);
        value.CopyTo(0, _buffer, index, value.Length);
        _length += value.Length;
        return this;
    }

    public ArrayStringBuilder Remove(int start, int count)
    {
        if (start < 0 || count < 0 || start + count > _length)
            throw new ArgumentOutOfRangeException(nameof(start));

        // shift tail left to fill the gap
        Array.Copy(_buffer, start + count, _buffer, start, _length - start - count);
        _length -= count;
        return this;
    }

    public ArrayStringBuilder Clear()
    {
        _length = 0;
        return this;
    }

    public override string ToString() => new string(_buffer, 0, _length);
}

public class ChunkedStringBuilder
{
    private readonly List<string> _chunks = new();
    private int _length;

    public int Length => _length;

    public ChunkedStringBuilder Append(string value)
    {
        if (value.Length == 0)
            return this;

        _chunks.Add(value);
        _length += value.Length;
        return this;
    }

    public ChunkedStringBuilder Append(char value) => Append(value.ToString());

    public ChunkedStringBuilder Clear()
    {
        _chunks.Clear();
        _length = 0;
        return this;
    }

    // Join every chunk into a single string, only done on demand
    public override string ToString()
    {
        var result = new char[_length];
        var offset = 0;
        foreach (var chunk in _chunks)
        {
            chunk.CopyTo(0, result, offset, chunk.Length);
            offset += chunk.Length;
        }
        return new string(result);
    }
}```