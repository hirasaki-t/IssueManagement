import { Meta, Story } from "@storybook/react/types-6-0";
import IssueListTable from "../components/IssueListTable";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/IssueListTable",
    decorators: [StoryRouter()],
    components: IssueListTable,
} as Meta;

const Template: Story = () => <IssueListTable />;

export const Default = Template.bind({});