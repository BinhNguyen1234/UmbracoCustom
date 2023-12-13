
import { ReactElement } from "react";

export default function Layout( props: {
    aboutme: ReactElement;
    blog: ReactElement;
    params: {
        route: string
    }
}) {
    const route = props.params.route
    const RenderComponent = (props as any)[route]()
    return (
        <>
            <RenderComponent></RenderComponent>
        </>
    );
}
// interface RoutesDefine {
//     aboutme: ReactElement;
//     blog: ReactElement;
// }
