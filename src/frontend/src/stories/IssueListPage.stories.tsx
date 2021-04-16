import { Meta, Story } from "@storybook/react/types-6-0";
import IssueListPage from "../pages/IssueListPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/IssueListPage",
    decorators: [StoryRouter()],
    components: IssueListPage,
} as Meta;

const Template: Story = () => <IssueListPage />;

export const Default = Template.bind({});