import { background, Color, stroke } from "./fable_modules/PerfectFifth.0.1.86/Color.fs.js";
import { Node$, display } from "./fable_modules/PerfectFifth.0.1.86/P5.fs.js";

export function draw(p5) {
    p5.resizeCanvas(720, 400);
    stroke(p5, new Color(2, [255]));
    const y = (p5.height) * 0.5;
    const width = p5.width;
    background(p5, new Color(2, [0]));
    p5.line(0, y, width, y);
}

display(new Node$(0, [".canvas-wrapper"]), (p) => {
    draw(p);
});

