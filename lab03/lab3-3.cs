using System;

const int N = 5;
var events = new[] { "e1", "e2", "e3", "e4", "e5", "e6", "e7", "e8" };

var buffer = new string[N];
int next = 0;
int count = 0;

foreach (var e in events)
{
    buffer[next] = e;
    next = (next + 1) % N;
    if (count < N) count++;
}

int start = count < N ? 0 : next;
for (int k = 0; k < count; k++)
    Console.WriteLine(buffer[(start + k) % N]);