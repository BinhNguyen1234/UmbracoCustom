
import { ReactElement } from "react";

export default function Layout( props: {
    aboutme: ReactElement;
    blog: ReactElement;
    params: {
        route: string
    }
}) {
    const route = props.params.route
    return (
        <>
            {(props as any)[route]}
        </>
    );
}
// interface RoutesDefine {
//     aboutme: ReactElement;
//     blog: ReactElement;
// }
