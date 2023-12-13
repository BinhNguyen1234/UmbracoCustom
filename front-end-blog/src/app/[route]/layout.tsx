"use client"

import { usePathname } from "next/navigation";
import { ReactElement } from "react";

export default function Layout(props: {
    aboutme: ReactElement,
    blog: ReactElement
}) {
    const segment = usePathname().replace(/^\//, "")
    console.log(segment)
    return <>
        {props[segment]}
    </>;
}
