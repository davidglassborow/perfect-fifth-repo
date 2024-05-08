// From https://github.com/mark-gerarts/perfect-fifth?tab=readme-ov-file#display

open Browser.Dom
open P5.Core
open P5.Rendering
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 =
    resizeCanvas p5 720 400
    stroke p5 (Grayscale 255)

    let y = (height p5 |> float) * 0.5
    let width = width p5 |> float

    background p5 (Grayscale 0)
    line2D p5 0 y width y

display (Selector ".canvas-wrapper") draw
// This line ends up throwing:
//[Error] TypeError: Object is not a constructor (evaluating 'new p5_2(p5Sketch, nodeElement)')
//	createSketch (P5.fs.js:379)
//	display (P5.fs.js:400)
//	Module Code (Program.fs.js:13)
