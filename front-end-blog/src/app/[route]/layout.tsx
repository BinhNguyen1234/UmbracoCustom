"use client"
import { ReactElement } from "react";
export default function Layout( props: {
    aboutme: ReactElement;
    blog: ReactElement;
    params: {
        route: string
    }
}) {
    const currentRoute = props.params.route
    const RenderComponent = (props as any)[currentRoute]
    return (
        <>
            {RenderComponent}
        </>
    );
}
// interface RoutesDefine {
//     aboutme: ReactElement;
//     blog: ReactElement;
// }
