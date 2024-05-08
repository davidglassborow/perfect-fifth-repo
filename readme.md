
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

Perfect fifth installation: https://github.com/mark-gerarts/perfect-fifth?tab=readme-ov-file#installation

```bash
#1. Add the package
dotnet add package PerfectFifth --prerelease

#2. Starter templates fixes - nothing to do, no longer needed, fable is .net8 already

#3. Add p5js dependency - note this installed latest 1.9.3, so manually changed the package.json back to 1.6.0
npm i --save p5@^1.6.0

#4. Add example display code from https://github.com/mark-gerarts/perfect-fifth?tab=readme-ov-file#display
```

On new clone, run the following to make sure all is setup correctly:

```bash
# Install node_modules from package.json and package-lock.json
npm install

# Restore tools from .config/dotnet-tools.json
dotnet tool restore

# Restore dotnet build
dotnet restore

# Test compile to JS, creates the fable_modules folder
dotnet fable

# Test vite is working, listens on http://localhost:5173/
npx vite
```

Then run in watch mode: `dotnet fable watch --verbose --run npx vite`
