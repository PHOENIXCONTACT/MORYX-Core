import { faTerminal } from "@fortawesome/fontawesome-free-solid";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import * as React from "react";
import NotificationSystem = require("react-notification-system");
import { connect, Dispatch } from "react-redux";
import { Button, ButtonGroup, Card, CardBody, CardHeader, Col, Container, ListGroup, ListGroupItem, Row } from "reactstrap";
import { updateShowWaitDialog } from "../../common/redux/CommonActions";
import { ActionType } from "../../common/redux/Types";
import ModulesRestClient from "../api/ModulesRestClient";
import ConsoleMethodConfigurator from "../components/ConsoleMethodConfigurator";
import ConsoleMethodResult from "../components/ConsoleMethodResult";
import Config from "../models/Config";
import Entry from "../models/Entry";
import MethodEntry from "../models/MethodEntry";

interface ModuleConsolePropModel {
    RestClient?: ModulesRestClient;
    ModuleName: string;
    NotificationSystem: NotificationSystem.System;
}

interface ModuleConsoleDispatchPropsModel {
    onShowWaitDialog?(showWaitDialog: boolean): void;
}

const mapDispatchToProps = (dispatch: Dispatch<ActionType<{}>>): ModuleConsoleDispatchPropsModel => {
    return {
        onShowWaitDialog: (showWaitDialog: boolean) => dispatch(updateShowWaitDialog(showWaitDialog)),
    };
};

interface InvokeResult {
    MethodName: string;
    Result: Entry;
}

interface ModuleConsoleStateModel {
    IsLoading: boolean;
    Methods: MethodEntry[];
    SelectedMethod: MethodEntry;
    InvokeResults: InvokeResult[];
}

class ModuleConsole extends React.Component<ModuleConsolePropModel & ModuleConsoleDispatchPropsModel, ModuleConsoleStateModel> {
    constructor(props: ModuleConsolePropModel & ModuleConsoleDispatchPropsModel) {
        super(props);

        this.state = { IsLoading: false, SelectedMethod: null, Methods: [], InvokeResults: [] };
    }

    public componentDidMount(): void {
        this.onReset();
    }

    private onReset(): void {
        this.setState({ Methods: [], SelectedMethod: null, IsLoading: true, InvokeResults: [] });
        this.props.RestClient.moduleMethods(this.props.ModuleName).then((data) => this.onModuleMethodsLoaded(data));
    }

    private onModuleMethodsLoaded(methods: MethodEntry[]): void {
        methods.forEach((element: MethodEntry) => {
            element.Parameters.forEach((parameter: Entry) => {
                Config.patchParent(parameter, null);
                Entry.generateUniqueIdentifiers(parameter);
            });
        });

        this.setState({ Methods: methods, IsLoading: false });
    }

    private onSelectMethod(methodEntry: MethodEntry): void {
        this.setState({SelectedMethod: methodEntry});
    }

    private onInvokeMethod(methodEntry: MethodEntry): void {
        this.props.onShowWaitDialog(true);

        this.props.RestClient.invokeMethod(this.props.ModuleName, methodEntry).then((data) => {
            this.props.onShowWaitDialog(false);
            Config.patchParent(data, null);
            this.onUpdateInvokeResults({ MethodName: methodEntry.Name, Result: data });
        });
    }

    private onUpdateInvokeResults(invokeResult: InvokeResult): void {
        this.setState((prevState) => ({ InvokeResults: [...prevState.InvokeResults.filter((r) => r.MethodName !== invokeResult.MethodName), invokeResult] }));
    }

    private invokeResult(methodName: string): InvokeResult {
        return this.state.InvokeResults.find((r: InvokeResult) => r.MethodName === methodName);
    }

    private resetInvokeResult(methodName: string): void {
        this.setState((prevState) => ({ InvokeResults: [...prevState.InvokeResults.filter((r) => r.MethodName !== methodName)] }));
    }

    private preRenderFunctions(): React.ReactNode {
        return (
            <ListGroup>

                {this.state.Methods.map((methodEntry, idx) => {
                    return (
                        <ListGroupItem key={idx}
                                       className="selectable"
                                       onClick={() => this.onSelectMethod(methodEntry)}
                                       active={this.state.SelectedMethod === methodEntry}>
                            {methodEntry.DisplayName}
                        </ListGroupItem>
                        );
                    })
                }
                </ListGroup>

        );
    }

    public render(): React.ReactNode {
        let content = (<span className="font-italic">No exported methods found.</span>);

        if (this.state.Methods.length > 0) {
            let view = <ConsoleMethodConfigurator Method={this.state.SelectedMethod}
                                                   ModuleName={this.props.ModuleName}
                                                   onInvokeMethod={this.onInvokeMethod.bind(this)} />;

            if (this.state.SelectedMethod != null) {
                const invokeResult = this.invokeResult(this.state.SelectedMethod.Name);

                if (invokeResult != null) {
                    view = <ConsoleMethodResult Method={this.state.SelectedMethod}
                                                InvokeResult={invokeResult.Result}
                                                onResetInvokeResult={this.resetInvokeResult.bind(this)} />;
                }
            }

            content = (
                <Container fluid={true} className="up-space-lg">
                    <Row>
                        <Col md={12}>
                            <Button color="primary"
                                    className="float-right"
                                    onClick={() => this.onReset()}>
                                    Reset
                            </Button>
                        </Col>
                    </Row>
                    <Row className="up-space-lg">
                        <Col md={5}>
                            {this.preRenderFunctions()}
                        </Col>
                        <Col md={7}>
                            {view}
                        </Col>
                    </Row>
                </Container>
            );
        }

        return (
            <Card>
                <CardHeader tag="h2">
                    <FontAwesomeIcon icon={faTerminal} className="right-space" />
                    {this.props.ModuleName} - Console
                </CardHeader>
                <CardBody>
                    {this.state.IsLoading ? (
                        <span className="up-space-lg font-italic">Loading available methods...</span>
                    ) : (
                        content
                    )}
                </CardBody>
            </Card>
        );
    }
}

export default connect<{}, ModuleConsoleDispatchPropsModel>(null, mapDispatchToProps)(ModuleConsole);
