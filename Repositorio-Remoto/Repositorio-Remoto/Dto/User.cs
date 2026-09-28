namespace Repositorio_Remoto.Dto;

public record User(
    int id,
    string name,
    string username,
    string email,
    Address address,
    string phone,
    string phone,
    string website,
    Company Company
);


public record Address(
    string street,
    string suite,
    string city,
    
);