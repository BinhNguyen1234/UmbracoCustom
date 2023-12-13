import { render, RenderOptions } from "@testing-library/react";
import React, { FC, ReactElement } from "react";
import fs from "fs";

const wrapper: FC<{ children: JSX.Element }> = ({ children }) => {
    return <>{children}</>;
};

const customRender = (ui: ReactElement, options?: Omit<RenderOptions, "wrapper">) => {
    const view = render(ui, { wrapper, ...options });
    const style = document.createElement("style");
    style.innerHTML = fs.readFileSync("src/MockupTesting/mockup-global.css", "utf8");
    document.head.appendChild(style);
    resizeWindow(1400, 1000)
    return view;
};
const resizeWindow = (x: number, y: number) => {
    window.innerWidth = x;
    window.innerHeight = y;
    window.dispatchEvent(new Event("resize"));
}

export * from "@testing-library/react";
export { customRender as render };
