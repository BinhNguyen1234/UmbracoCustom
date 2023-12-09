"use client" 
import ToggleButton from "@/UIComponent/ToggleBtn/ToggleBtn.component";
export default function DarkModeToggleBtn(){
    function switchThemes(){
        document.body.classList.toggle("dark")
    }
    return(<>
        <ToggleButton onInput={switchThemes}></ToggleButton>
    </>)
}