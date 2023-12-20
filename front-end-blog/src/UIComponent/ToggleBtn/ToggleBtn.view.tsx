"use client";
import React, { FormEventHandler } from "react";
const ToggleButton = ({
    onInput,
    children
}: {
    children?: JSX.Element
    onInput?: FormEventHandler<HTMLInputElement>;
}) => {
    return (
        <>
            <label className="block w-[100%] aspect-[2/1] bg-white border-black border-2  rounded-3xl p-[7%] hover:cursor-pointer dark:border-white dark:bg-black">
                <input
                    onInput={onInput}
                    className="sr-only peer"
                    type="checkbox"
                ></input>
                <div className="rounded-full bg-white peer-checked:translate-x-full ease duration-500 w-[50%] aspect-[1/1] dark:bg-black">
                    {children}
                </div>
            </label>
        </>
    );
};

export default ToggleButton;
