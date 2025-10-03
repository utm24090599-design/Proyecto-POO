# Small inventory application in C#

## Overview
This C# console application save a materials inventory. It collects and processes personal data for multiple individuals, including name, height, weight, and age. The program validates inputs, calculates the Body Mass Index (IMC), and identifies the youngest and tallest individuals.

## Key Features
- Input data for multiple people
- Validate materials
- Find the bigest and smallest colleted items
- Get a grup of items and calculate the total value
- Error handling for invalid inputs

## Input Validation
- Type of material: string
- Cantity of material: int
- Maximun: 100 kg per material
- Infinite materials until user decides to stop and it cleaned when it finished

## Method Workflow
1. Request type of material using a conbobox
2. Request cantity of material using a numericUpDown
3. Create parallel arrays for save data
4. Collect individual information with validation
5. Calculate and display:
   - Getted material
   - Minimum material getted

## Code Structure
- Uses parallel arrays for data storage
- Implements nested error-handling loops
- Utilizes LINQ for min/max calculations
- Handles potential input errors gracefully

## Usage Example
```csharp
// Program will interactively prompt for:
// - Number of people
// - Individual details (Type of material, cantity of material)
```

## Performance Considerations
- O(n) time complexity
- Memory efficient with fixed-size arrays
- Simple error handling mechanism

## Potential Improvements
- Implement object-oriented approach
- Add more comprehensive input validation
- Create custom exception handling
- Support persistent data storage

## List filtering and sorting
The list of material have some filters to grup and get plus when it is the same materia:
```
var resumen = tiposMateriales
                .Select((tipo, idx) => new { Tipo = tipo, Cantidad = cantidades[idx] }) //Seleciona cada elemento y su inice
                .GroupBy(x => x.Tipo) // Agrupa por tipo de material donde x se declara como un a veriable temporal y el elemento "=>" es una funcion lambda
                .OrderBy(g => g.Key); // Ordena los grupos por el nombre del material (Key)
```

## Error Handling Strategy
- All data have a defined structure
- Skips show if the list is empty
- Shows a message if no data is entered