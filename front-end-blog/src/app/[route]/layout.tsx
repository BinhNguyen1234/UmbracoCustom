"use client"
import { notFound } from "next/navigation";
import { ReactElement } from "react";
export default function Layout( props: {
    about: ReactElement;
    blog: ReactElement;
    home: ReactElement
    params: {
        route: string
    }
}) {
    const currentRoute = props.params.route
    const RenderComponent = (props as any)[currentRoute]
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
