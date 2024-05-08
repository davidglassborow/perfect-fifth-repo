
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
#1. setup npm
npm init -y

#2. Add vite
npm i -D vite

#3. add vite.config.ts
# done manually

#4. add index.html
# done manually

#5. Run vite and check it works
npx vite

#6. add dom package
dotnet add package Fable.Browser.Dom

#7. change contents of Program.fs
# done manually

#8. confirm all works ok by running fable in watch mode
dotnet fable watch --verbose --run npx vite
```