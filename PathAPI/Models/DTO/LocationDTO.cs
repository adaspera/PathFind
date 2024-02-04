namespace PathAPI.DTO;

public record LocationDTO(
    string Country,
    string Name, 
    double Lat,
    double Lng
    );