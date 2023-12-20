import { IHeaderEntity, IHeaderData } from "./header/header.type";
import { INavBarData, INavBarEntity } from "./header/navbar/navbar.type";
import { ILayoutData, ILayoutEntity } from "./layout.type";
import NavBarEntity from "./header/navbar/navbar";
import HeaderEntity from "./header/header";
import LayoutEntity from "./layout"


export type { IHeaderData, IHeaderEntity, INavBarData, INavBarEntity, ILayoutData, ILayoutEntity }
export { NavBarEntity, HeaderEntity, LayoutEntity }