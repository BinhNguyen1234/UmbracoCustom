import React, { useState } from "react";

const DarkModeBtn = () => {
    return (
        <>
        <label style={{backgroundColor: "black"}} className="w-[100%] aspect-[2/1] hover:cursor-pointer block rounded-3xl p-[7%]">
            <input  className="sr-only peer" type="checkbox"></input>
            <div style={{backgroundColor: "white"}} className="rounded-full peer-checked:translate-x-full ease duration-500 w-[50%] aspect-[1/1]"></div>
        </label>
        </>
    );
};

export default DarkModeBtn;
