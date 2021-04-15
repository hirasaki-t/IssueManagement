import { Meta, Story } from "@storybook/react/types-6-0";
import IssueListPage from "../pages/IssueListPage";

export default {
    title: "pages/IssueListPage",
    components: IssueListPage,
} as Meta;

const Template: Story = () => <IssueListPage />;

export const Default = Template.bind({});