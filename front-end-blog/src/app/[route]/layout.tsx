"use client"
import { notFound } from "next/navigation";
import { ReactElement } from "react";



export default function Layout( props: {
    about: ReactElement;
    blog: ReactElement;
    home: ReactElement;
    params: {
        route: string
    }
    [key: string]: any 
}) {
    const currentRoute: string = props.params.route
    const RenderComponent: ReactElement = props[currentRoute]
    return (
        <>
            {RenderComponent || notFound()}
        </>
    );
}
// interface RoutesDefine {
//     aboutme: ReactElement;
//     blog: ReactElement;
// }
