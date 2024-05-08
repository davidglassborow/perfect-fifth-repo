
Fable install instructions: https://fable.io/docs/getting-started/your-first-fable-project.html

```bash
#1. new console app
dotnet new console -lang F#

#2. install fable
dotnet new tool-manifest
dotnet tool install fable

#3. add fable core and transpile to JS
dotnet add package Fable.Core
dotnet fable
```

Javascript install: https://fable.io/docs/getting-started/javascript.html#browser

```bash
#4. setup npm
npm init -y

#5. Add vite
npm i -D vite

#6. add vite.config.ts
# done manually
```