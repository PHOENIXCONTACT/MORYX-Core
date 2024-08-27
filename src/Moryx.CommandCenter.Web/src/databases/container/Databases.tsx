/*
 * Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
 * Licensed under the Apache License, Version 2.0
*/

import { mdiBriefcase, mdiComment, mdiDatabase } from "@mdi/js";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import Grid from "@mui/material/Grid";
import List from "@mui/material/List";
import ListItemButton from "@mui/material/ListItemButton";
import ListItemText from "@mui/material/ListItemText";
import Skeleton from "@mui/material/Skeleton";
import Tab from "@mui/material/Tab";
import Tabs from "@mui/material/Tabs";
import * as React from "react";
import { connect } from "react-redux";
import { Link, Route, Routes } from "react-router-dom";
import RoutingMenu from "../../common/components/Menu/RoutingMenu";
import { SectionInfo } from "../../common/components/SectionInfo";
import MenuItemModel from "../../common/models/MenuItemModel";
import MenuModel from "../../common/models/MenuModel";
import { AppState } from "../../common/redux/AppState";
import { ActionType } from "../../common/redux/Types";
import DatabasesRestClient from "../api/DatabasesRestClient";
import DataModel from "../models/DataModel";
import { updateDatabaseConfigs } from "../redux/DatabaseActions";
import DatabaseModel from "./DatabaseModel";

interface DatabasesPropsModel {
    RestClient?: DatabasesRestClient;
    DatabaseConfigs?: DataModel[];
}

interface DatabasesDispatchPropModel {
    onUpdateDatabaseConfigs?(databaseConfigs: DataModel[]): void;
}

const mapStateToProps = (state: AppState): DatabasesPropsModel => {
    return {
        RestClient: state.Databases.RestClient,
        DatabaseConfigs: state.Databases.DatabaseConfigs
    };
};

const mapDispatchToProps = (dispatch: React.Dispatch<ActionType<{}>>): DatabasesDispatchPropModel => {
    return {
        onUpdateDatabaseConfigs: (databaseConfigs: DataModel[]) => dispatch(updateDatabaseConfigs(databaseConfigs)),
    };
};

interface DatabaseStateModel {
    MenuModel: MenuModel;
    IsLoading: boolean;
}

class Database extends React.Component<DatabasesPropsModel & DatabasesDispatchPropModel, DatabaseStateModel> {
    constructor(props: DatabasesPropsModel & DatabasesDispatchPropModel) {
        super(props);
        this.state = { MenuModel: { MenuItems: [] }, IsLoading: false };
    }

    public componentDidMount(): void {
        this.loadDatabases();
    }

    private loadDatabases(): void {
        this.setState({ IsLoading: true });

        this.props.RestClient.databaseModels().then((data) => {
            const validModels = data.databases.filter((model) => model);
            this.props.onUpdateDatabaseConfigs(validModels);
            this.setState({ MenuModel: { MenuItems: validModels.map((dataModel, idx) => Database.createMenuItem(dataModel)) }, IsLoading: false });
        });
    }

    private static createMenuItem(dataModel: DataModel): MenuItemModel {
        const context = dataModel.targetModel.replace(/^.+\./, "");
        const namespace = dataModel.targetModel.replace("." + context, "");
        return {
            Name: context,
            NavPath: "/databases/" + dataModel.targetModel,
            Icon: mdiBriefcase,
            SecondaryName: namespace,
            SubMenuItems: [],
        };
    }

    public preRenderRoutesList(): any[] {
        const routes: any[] = [];
        let idx = 0;

        this.props.DatabaseConfigs.forEach((model) => {
            routes.push(
                <Route key={idx} path={`${model.targetModel}`} element={
                    <DatabaseModel DataModel={model} RestClient={this.props.RestClient} />} />);
            ++idx;
        });

        return routes;
    }

    public render(): React.ReactNode {
        return (
            <Grid container={true} spacing={2}>
                <Grid item={true} md={3}
                    justifyContent={"center"}>
                    <Card className="mcc-menu-card">
                            <Tabs value="databases" role="navigation" centered={true}>
                                <Tab label="Modules" value="modules" component={Link} to="/modules" />
                                <Tab label="Databases" value="databases" component={Link} to="/databases" />
                            </Tabs>
                        {this.state.IsLoading ? (
                            <List>
                                <ListItemButton
                                    className="menu-item"
                                    divider={true}
                                    disabled={true}>
                                    <ListItemText>
                                        <Skeleton animation="wave" variant="text" sx={{width: "70%", fontSize: "1.2rem"}} />
                                        <Skeleton animation="wave" variant="text" sx={{width: "95%", fontSize: "0.5rem"}} />
                                    </ListItemText>
                                </ListItemButton>
                                <ListItemButton
                                    className="menu-item"
                                    divider={true}
                                    disabled={true}>
                                    <ListItemText>
                                        <Skeleton animation="wave" variant="text" sx={{width: "70%", fontSize: "1.2rem"}} />
                                        <Skeleton animation="wave" variant="text" sx={{width: "95%", fontSize: "0.5rem"}} />
                                    </ListItemText>
                                </ListItemButton>
                            </List>
                        ) : (
                            <RoutingMenu Menu={this.state.MenuModel} />
                        )}
                    </Card>
                </Grid>
                <Grid item={true} md={9}>
                    <Routes>
                        <Route path="*" element={
                            <Card>
                                <CardContent>
                                    <SectionInfo
                                        description="Configure all available database models. Please select a database model to proceed."
                                        icon={mdiDatabase}
                                    />
                                </CardContent>
                            </Card>}
                        />
                        {this.preRenderRoutesList()}
                    </Routes>
                </Grid>
            </Grid>
        );
    }
}

export default connect<DatabasesPropsModel, DatabasesDispatchPropModel>(mapStateToProps, mapDispatchToProps)(Database);
