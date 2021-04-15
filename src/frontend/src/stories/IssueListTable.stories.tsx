import { Meta, Story } from "@storybook/react/types-6-0";
import IssueListTable from "../components/IssueListTable";

export default {
    title: "components/IssueListTable",
    components: IssueListTable,
} as Meta;

const Template: Story = () => <IssueListTable />;

export const Default = Template.bind({});