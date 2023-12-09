import { cleanup, fireEvent } from "@testing-library/react";
import  "@testing-library/jest-dom";
import DarkModeBtn from "./ToggleBtn.component";
import { render } from "@/MockupTesting/CustomRenderToAddCssGlobal"
import ToggleButton from "./ToggleBtn.component";
// import GlobalComponent from "@/testing/GlobalComponent";
afterEach(cleanup);
describe("UI check", () => {
    it("UI DarkModeBtn", () => {
        const component = render(<ToggleButton />);
        const Label = component.container.querySelector(
            "label[class='w-[100%] aspect-[2/1] block rounded-3xl p-[7%]']"
        );
        const input = component.container.querySelector(
            "input[class='sr-only peer']"
        );
        const Div = component.container.querySelector(
            "div[class='rounded-full peer-checked:translate-x-full ease duration-500 w-[50%] aspect-[1/1]']"
        );
        console.log(window.innerWidth)
        expect(input).toBeTruthy();
        expect(Label).toBeTruthy();
        expect(Div).toBeTruthy();
        fireEvent.click(Label as Element);  
        const fff = window.getComputedStyle(Div as Element)
        expect(input).toBeChecked()
        console.log(fff)
    });
});
