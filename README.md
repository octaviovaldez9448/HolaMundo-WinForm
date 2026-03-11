# HolaMundo - Validación de Contraseña

Aplicación de Windows Forms en C# que valida una contraseña usando una expresión regular (Regex).

## Requisitos de la contraseña

La contraseña debe contener:

- Al menos una letra mayúscula
- Al menos una letra minúscula
- Al menos un número
- Al menos un símbolo

También se valida que ambos campos de contraseña coincidan.

## Funcionamiento

1. El usuario escribe la contraseña
2. El sistema valida su estructura con Regex
3. Se compara con el segundo campo
4. Si todo es correcto aparece el mensaje:

"La contraseña ha sido validada"

## Capturas

### Contraseña inválida
![invalid](screenshots/validar-contraseña.png)

### Contraseñas diferentes
![different](screenshots/validar-similitud.png)

### Validación correcta
![valid](screenshots/validación-correcta.png)
