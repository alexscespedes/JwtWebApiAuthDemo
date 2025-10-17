using System;

namespace JwtAuthDemo.DTOs;

public record LoginDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
