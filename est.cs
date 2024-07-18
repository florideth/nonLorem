using System;

public class PinchDetector
{
    // Declare the event
    public event Action<float, float> onPinch;

    // Method to simulate detecting a pinch gesture
    public void DetectPinch(float scale, float velocity)
    {
        // Check if there are any subscribers to the event
        if (onPinch != null)
        {
            // Raise the event with the given parameters
            onPinch(scale, velocity);
        }
    }
}

// Example usage of the PinchDetector class
public class Program
{
    static void Main()
    {
        // Create an instance of the PinchDetector
        PinchDetector detector = new PinchDetector();

        // Subscribe to the onPinch event
        detector.onPinch += HandlePinch;

        // Simulate a pinch detection
        detector.DetectPinch(1.5f, 0.75f);
    }

    // Event handler method
    static void HandlePinch(float scale, float velocity)
    {
        Console.WriteLine($"Pinch detected with scale: {scale} and velocity: {velocity}");
    }
}
