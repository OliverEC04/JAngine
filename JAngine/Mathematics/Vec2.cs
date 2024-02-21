﻿namespace JAngine.Mathematics;

/// <summary>
/// A vector with 2 float components.
/// </summary>
public readonly struct Vec2
{
    private readonly float _x;
    private readonly float _y;
    
    /// <summary>
    /// Constructs a Vec2 using an x and y component.
    /// </summary>
    /// <param name="x">The first component of the vector.</param>
    /// <param name="y">The second component of the vector.</param>
    public Vec2(float x, float y)
    {
        _x = x;
        _y = y;
    }

    /// <summary>
    /// Constructs a Vec2 using a single value for both x and y.
    /// </summary>
    /// <param name="value">The value of all components in the vector.</param>
    public Vec2(float value)
    {
        _x = value;
        _y = value;
    }

    /// <summary>
    /// Returns the first value of the vector.
    /// </summary>
    public float X => _x;
    
    /// <summary>
    /// Returns the second value of the vector.
    /// </summary>
    public float Y => _y;
    
    /// <summary>
    /// Returns the first value of the vector.
    /// </summary>
    public float R => _x;
    
    /// <summary>
    /// Returns the second value of the vector.
    /// </summary>
    public float G => _y;

    /// <summary>
    /// Calculates the length of the vector.
    /// </summary>
    /// <returns>Returns the length of the vector, i.e. '√(X² + Y²)'.</returns>
    public float Length()
    {
        return (float)Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
    }
    
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="left">Specifies the first of two vectors.</param>
    /// <param name="right">Specifies the second of two vectors.</param>
    /// <returns>Returns the dot product of two vectors, left and right. i.e., 'left.X * right.X + left.Y * right.Y'.</returns>
    public static float Dot(Vec2 left, Vec2 right)
    {
        return left.X * right.X + left.Y * right.Y;
    }
    
    /// <summary>
    /// Calculates the distance between two points.
    /// </summary>
    /// <param name="p0">Specifies the first of two points.</param>
    /// <param name="p1">Specifies the second of two points.</param>
    /// <returns>Returns the distance between the two points p0 and p1. i.e., 'length(p0 - p1)'.</returns>
    public static float Distance(Vec2 p0, Vec2 p1)
    {
        return (float)Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2));
    }
}