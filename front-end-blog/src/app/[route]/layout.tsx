"use client";

import { usePathname } from "next/navigation";
import { ReactElement } from "react";

export default function Layout( props: {
    aboutme: ReactElement;
    blog: ReactElement;
}) {
    const segment = usePathname().replace(/^\//, "");
    return (
        <>
            {(props as any)[segment]}
        </>
    );
}
// interface RoutesDefine {
//     aboutme: ReactElement;
//     blog: ReactElement;
// }
